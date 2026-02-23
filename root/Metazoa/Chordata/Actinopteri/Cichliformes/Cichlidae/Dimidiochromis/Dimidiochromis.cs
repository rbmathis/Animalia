using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Dimidiochromis;

/// <summary>
/// Abstract class for Dimidiochromis (genus).
/// NCBI TaxId: 106583
/// </summary>
public abstract class Dimidiochromis : Cichlidae, IDimidiochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dimidiochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 106583;

    /// <inheritdoc />
    public virtual string GenusName => "Dimidiochromis";

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
