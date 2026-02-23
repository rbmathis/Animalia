using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Ischikauia;

/// <summary>
/// Abstract class for Ischikauia (genus).
/// NCBI TaxId: 180932
/// </summary>
public abstract class Ischikauia : Xenocyprididae, IIschikauia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ischikauia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 180932;

    /// <inheritdoc />
    public virtual string GenusName => "Ischikauia";

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
