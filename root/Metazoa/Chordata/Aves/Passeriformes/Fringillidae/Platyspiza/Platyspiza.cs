using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Platyspiza;

/// <summary>
/// Abstract class for Platyspiza (genus).
/// NCBI TaxId: 48887
/// </summary>
public abstract class Platyspiza : Fringillidae, IPlatyspiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platyspiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48887;

    /// <inheritdoc />
    public virtual string GenusName => "Platyspiza";

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
