using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Abramis;

/// <summary>
/// Abstract class for Abramis (genus).
/// NCBI TaxId: 38526
/// </summary>
public abstract class Abramis : Leuciscidae, IAbramis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Abramis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 38526;

    /// <inheritdoc />
    public virtual string GenusName => "Abramis";

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
