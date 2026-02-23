using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Chimaeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Chimaeridae.Chimaera;

/// <summary>
/// Abstract class for Chimaera (genus).
/// NCBI TaxId: 7870
/// </summary>
public abstract class Chimaera : Chimaeridae, IChimaera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chimaera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7870;

    /// <inheritdoc />
    public virtual string GenusName => "Chimaera";

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
