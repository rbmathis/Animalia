using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Doradidae.Hypodoras;

/// <summary>
/// Abstract class for Hypodoras (genus).
/// NCBI TaxId: 238564
/// </summary>
public abstract class Hypodoras : Doradidae, IHypodoras
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypodoras";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238564;

    /// <inheritdoc />
    public virtual string GenusName => "Hypodoras";

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
