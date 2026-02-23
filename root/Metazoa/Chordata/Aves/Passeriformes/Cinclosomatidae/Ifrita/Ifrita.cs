using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae.Ifrita;

/// <summary>
/// Abstract class for Ifrita (genus).
/// NCBI TaxId: 461243
/// </summary>
public abstract class Ifrita : Cinclosomatidae, IIfrita
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ifrita";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 461243;

    /// <inheritdoc />
    public virtual string GenusName => "Ifrita";

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
