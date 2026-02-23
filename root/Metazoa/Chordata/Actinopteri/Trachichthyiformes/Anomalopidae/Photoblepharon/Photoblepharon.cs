using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anomalopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Trachichthyiformes.Anomalopidae.Photoblepharon;

/// <summary>
/// Abstract class for Photoblepharon (genus).
/// NCBI TaxId: 241832
/// </summary>
public abstract class Photoblepharon : Anomalopidae, IPhotoblepharon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Photoblepharon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241832;

    /// <inheritdoc />
    public virtual string GenusName => "Photoblepharon";

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
