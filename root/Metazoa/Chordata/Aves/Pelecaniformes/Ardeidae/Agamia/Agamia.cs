using AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Pelecaniformes.Ardeidae.Agamia;

/// <summary>
/// Abstract class for Agamia (genus).
/// NCBI TaxId: 706244
/// </summary>
public abstract class Agamia : Ardeidae, IAgamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Agamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 706244;

    /// <inheritdoc />
    public virtual string GenusName => "Agamia";

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
