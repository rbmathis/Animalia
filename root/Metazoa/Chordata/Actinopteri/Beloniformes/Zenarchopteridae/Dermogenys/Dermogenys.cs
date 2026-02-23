using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Zenarchopteridae.Dermogenys;

/// <summary>
/// Abstract class for Dermogenys (genus).
/// NCBI TaxId: 129045
/// </summary>
public abstract class Dermogenys : Zenarchopteridae, IDermogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dermogenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129045;

    /// <inheritdoc />
    public virtual string GenusName => "Dermogenys";

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
