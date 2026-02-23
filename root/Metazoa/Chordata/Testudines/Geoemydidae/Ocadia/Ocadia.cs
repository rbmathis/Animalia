using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Ocadia;

/// <summary>
/// Abstract class for Ocadia (genus).
/// NCBI TaxId: 72009
/// </summary>
public abstract class Ocadia : Geoemydidae, IOcadia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ocadia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72009;

    /// <inheritdoc />
    public virtual string GenusName => "Ocadia";

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
