using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Albuliformes.Albulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Albuliformes.Albulidae.Pterothrissus;

/// <summary>
/// Abstract class for Pterothrissus (genus).
/// NCBI TaxId: 121284
/// </summary>
public abstract class Pterothrissus : Albulidae, IPterothrissus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterothrissus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121284;

    /// <inheritdoc />
    public virtual string GenusName => "Pterothrissus";

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
