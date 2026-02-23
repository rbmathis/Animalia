using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Artamidae.Peltops;

/// <summary>
/// Abstract class for Peltops (genus).
/// NCBI TaxId: 626434
/// </summary>
public abstract class Peltops : Artamidae, IPeltops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Peltops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 626434;

    /// <inheritdoc />
    public virtual string GenusName => "Peltops";

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
