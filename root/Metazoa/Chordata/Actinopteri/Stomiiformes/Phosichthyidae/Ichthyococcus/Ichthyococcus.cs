using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae.Ichthyococcus;

/// <summary>
/// Abstract class for Ichthyococcus (genus).
/// NCBI TaxId: 473373
/// </summary>
public abstract class Ichthyococcus : Phosichthyidae, IIchthyococcus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ichthyococcus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 473373;

    /// <inheritdoc />
    public virtual string GenusName => "Ichthyococcus";

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
