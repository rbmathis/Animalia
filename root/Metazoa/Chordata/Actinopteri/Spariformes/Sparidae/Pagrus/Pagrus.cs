using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Pagrus;

/// <summary>
/// Abstract class for Pagrus (genus).
/// NCBI TaxId: 8172
/// </summary>
public abstract class Pagrus : Sparidae, IPagrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pagrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8172;

    /// <inheritdoc />
    public virtual string GenusName => "Pagrus";

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
