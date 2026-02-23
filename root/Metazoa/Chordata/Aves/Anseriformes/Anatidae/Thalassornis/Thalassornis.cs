using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Thalassornis;

/// <summary>
/// Abstract class for Thalassornis (genus).
/// NCBI TaxId: 56305
/// </summary>
public abstract class Thalassornis : Anatidae, IThalassornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thalassornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56305;

    /// <inheritdoc />
    public virtual string GenusName => "Thalassornis";

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
