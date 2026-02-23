using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Ceblepyris;

/// <summary>
/// Abstract class for Ceblepyris (genus).
/// NCBI TaxId: 3240216
/// </summary>
public abstract class Ceblepyris : Campephagidae, ICeblepyris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ceblepyris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3240216;

    /// <inheritdoc />
    public virtual string GenusName => "Ceblepyris";

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
