using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae.Remorina;

/// <summary>
/// Abstract class for Remorina (genus).
/// NCBI TaxId: 641295
/// </summary>
public abstract class Remorina : Echeneidae, IRemorina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Remorina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641295;

    /// <inheritdoc />
    public virtual string GenusName => "Remorina";

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
