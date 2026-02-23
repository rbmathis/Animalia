using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Anaplectes;

/// <summary>
/// Abstract class for Anaplectes (genus).
/// NCBI TaxId: 907499
/// </summary>
public abstract class Anaplectes : Ploceidae, IAnaplectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anaplectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 907499;

    /// <inheritdoc />
    public virtual string GenusName => "Anaplectes";

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
