using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Catharus;

/// <summary>
/// Abstract class for Catharus (genus).
/// NCBI TaxId: 9184
/// </summary>
public abstract class Catharus : Turdidae, ICatharus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Catharus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9184;

    /// <inheritdoc />
    public virtual string GenusName => "Catharus";

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
