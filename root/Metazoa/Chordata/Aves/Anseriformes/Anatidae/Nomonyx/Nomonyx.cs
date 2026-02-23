using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Nomonyx;

/// <summary>
/// Abstract class for Nomonyx (genus).
/// NCBI TaxId: 90705
/// </summary>
public abstract class Nomonyx : Anatidae, INomonyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nomonyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 90705;

    /// <inheritdoc />
    public virtual string GenusName => "Nomonyx";

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
