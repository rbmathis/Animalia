using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Dalophis;

/// <summary>
/// Abstract class for Dalophis (genus).
/// NCBI TaxId: 1789961
/// </summary>
public abstract class Dalophis : Ophichthidae, IDalophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dalophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1789961;

    /// <inheritdoc />
    public virtual string GenusName => "Dalophis";

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
