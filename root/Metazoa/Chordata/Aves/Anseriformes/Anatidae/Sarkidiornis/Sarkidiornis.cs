using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Sarkidiornis;

/// <summary>
/// Abstract class for Sarkidiornis (genus).
/// NCBI TaxId: 8886
/// </summary>
public abstract class Sarkidiornis : Anatidae, ISarkidiornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sarkidiornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8886;

    /// <inheritdoc />
    public virtual string GenusName => "Sarkidiornis";

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
