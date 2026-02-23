using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Pangshura;

/// <summary>
/// Abstract class for Pangshura (genus).
/// NCBI TaxId: 1216468
/// </summary>
public abstract class Pangshura : Geoemydidae, IPangshura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pangshura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1216468;

    /// <inheritdoc />
    public virtual string GenusName => "Pangshura";

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
