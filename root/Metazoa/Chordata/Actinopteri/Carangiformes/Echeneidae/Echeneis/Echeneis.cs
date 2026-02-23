using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae.Echeneis;

/// <summary>
/// Abstract class for Echeneis (genus).
/// NCBI TaxId: 173246
/// </summary>
public abstract class Echeneis : Echeneidae, IEcheneis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echeneis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 173246;

    /// <inheritdoc />
    public virtual string GenusName => "Echeneis";

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
