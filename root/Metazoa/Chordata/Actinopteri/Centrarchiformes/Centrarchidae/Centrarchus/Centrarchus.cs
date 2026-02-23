using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Centrarchus;

/// <summary>
/// Abstract class for Centrarchus (genus).
/// NCBI TaxId: 201693
/// </summary>
public abstract class Centrarchus : Centrarchidae, ICentrarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centrarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201693;

    /// <inheritdoc />
    public virtual string GenusName => "Centrarchus";

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
