using AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Diomedeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Diomedeidae.Thalassarche;

/// <summary>
/// Abstract class for Thalassarche (genus).
/// NCBI TaxId: 329933
/// </summary>
public abstract class Thalassarche : Diomedeidae, IThalassarche
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thalassarche";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329933;

    /// <inheritdoc />
    public virtual string GenusName => "Thalassarche";

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
