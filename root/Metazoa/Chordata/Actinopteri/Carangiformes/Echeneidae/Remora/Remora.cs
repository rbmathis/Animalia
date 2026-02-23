using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Echeneidae.Remora;

/// <summary>
/// Abstract class for Remora (genus).
/// NCBI TaxId: 305630
/// </summary>
public abstract class Remora : Echeneidae, IRemora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Remora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 305630;

    /// <inheritdoc />
    public virtual string GenusName => "Remora";

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
