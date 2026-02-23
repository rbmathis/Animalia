using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Euplectes;

/// <summary>
/// Abstract class for Euplectes (genus).
/// NCBI TaxId: 187428
/// </summary>
public abstract class Euplectes : Ploceidae, IEuplectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euplectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187428;

    /// <inheritdoc />
    public virtual string GenusName => "Euplectes";

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
