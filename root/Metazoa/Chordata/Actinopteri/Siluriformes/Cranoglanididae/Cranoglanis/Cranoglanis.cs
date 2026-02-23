using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cranoglanididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Cranoglanididae.Cranoglanis;

/// <summary>
/// Abstract class for Cranoglanis (genus).
/// NCBI TaxId: 175799
/// </summary>
public abstract class Cranoglanis : Cranoglanididae, ICranoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cranoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175799;

    /// <inheritdoc />
    public virtual string GenusName => "Cranoglanis";

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
