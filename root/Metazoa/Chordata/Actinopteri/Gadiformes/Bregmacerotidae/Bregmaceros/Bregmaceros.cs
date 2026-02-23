using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Bregmacerotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Bregmacerotidae.Bregmaceros;

/// <summary>
/// Abstract class for Bregmaceros (genus).
/// NCBI TaxId: 181411
/// </summary>
public abstract class Bregmaceros : Bregmacerotidae, IBregmaceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bregmaceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 181411;

    /// <inheritdoc />
    public virtual string GenusName => "Bregmaceros";

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
