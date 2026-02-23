using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Carpodectes;

/// <summary>
/// Abstract class for Carpodectes (genus).
/// NCBI TaxId: 114273
/// </summary>
public abstract class Carpodectes : Cotingidae, ICarpodectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carpodectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 114273;

    /// <inheritdoc />
    public virtual string GenusName => "Carpodectes";

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
