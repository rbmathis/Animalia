using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Nyctanassa;

/// <summary>
/// Abstract class for Nyctanassa (genus).
/// NCBI TaxId: 56293
/// </summary>
public abstract class Nyctanassa : Ardeidae, INyctanassa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctanassa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56293;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctanassa";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
