using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Bellapiscis;

/// <summary>
/// Abstract class for Bellapiscis (genus).
/// NCBI TaxId: 582523
/// </summary>
public abstract class Bellapiscis : Tripterygiidae, IBellapiscis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bellapiscis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 582523;

    /// <inheritdoc />
    public virtual string GenusName => "Bellapiscis";

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
