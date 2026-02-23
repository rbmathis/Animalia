using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Notropis;

/// <summary>
/// Abstract class for Notropis (genus).
/// NCBI TaxId: 28793
/// </summary>
public abstract class Notropis : Leuciscidae, INotropis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notropis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28793;

    /// <inheritdoc />
    public virtual string GenusName => "Notropis";

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
