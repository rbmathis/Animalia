using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Mylossoma;

/// <summary>
/// Abstract class for Mylossoma (genus).
/// NCBI TaxId: 42521
/// </summary>
public abstract class Mylossoma : Serrasalmidae, IMylossoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mylossoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42521;

    /// <inheritdoc />
    public virtual string GenusName => "Mylossoma";

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
