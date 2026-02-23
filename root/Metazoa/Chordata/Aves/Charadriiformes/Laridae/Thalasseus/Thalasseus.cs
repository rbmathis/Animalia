using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Thalasseus;

/// <summary>
/// Abstract class for Thalasseus (genus).
/// NCBI TaxId: 555355
/// </summary>
public abstract class Thalasseus : Laridae, IThalasseus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thalasseus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 555355;

    /// <inheritdoc />
    public virtual string GenusName => "Thalasseus";

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
