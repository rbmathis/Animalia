using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cotingidae.Rupicola;

/// <summary>
/// Abstract class for Rupicola (genus).
/// NCBI TaxId: 81893
/// </summary>
public abstract class Rupicola : Cotingidae, IRupicola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rupicola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81893;

    /// <inheritdoc />
    public virtual string GenusName => "Rupicola";

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
