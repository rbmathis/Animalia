using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Hardella;

/// <summary>
/// Abstract class for Hardella (genus).
/// NCBI TaxId: 204953
/// </summary>
public abstract class Hardella : Geoemydidae, IHardella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hardella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 204953;

    /// <inheritdoc />
    public virtual string GenusName => "Hardella";

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
