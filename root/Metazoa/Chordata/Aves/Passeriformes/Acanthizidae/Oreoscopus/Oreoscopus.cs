using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Oreoscopus;

/// <summary>
/// Abstract class for Oreoscopus (genus).
/// NCBI TaxId: 626432
/// </summary>
public abstract class Oreoscopus : Acanthizidae, IOreoscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreoscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 626432;

    /// <inheritdoc />
    public virtual string GenusName => "Oreoscopus";

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
