using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Chimaeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Chimaeridae.Hydrolagus;

/// <summary>
/// Abstract class for Hydrolagus (genus).
/// NCBI TaxId: 7872
/// </summary>
public abstract class Hydrolagus : Chimaeridae, IHydrolagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrolagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7872;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrolagus";

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
