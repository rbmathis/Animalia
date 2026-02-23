using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Eolophus;

/// <summary>
/// Abstract class for Eolophus (genus).
/// NCBI TaxId: 176038
/// </summary>
public abstract class Eolophus : Cacatuidae, IEolophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eolophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 176038;

    /// <inheritdoc />
    public virtual string GenusName => "Eolophus";

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
