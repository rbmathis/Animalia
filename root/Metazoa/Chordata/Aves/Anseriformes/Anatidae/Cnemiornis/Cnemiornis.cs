using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cnemiornis;

/// <summary>
/// Abstract class for Cnemiornis (genus).
/// NCBI TaxId: 3380694
/// </summary>
public abstract class Cnemiornis : Anatidae, ICnemiornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cnemiornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3380694;

    /// <inheritdoc />
    public virtual string GenusName => "Cnemiornis";

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
