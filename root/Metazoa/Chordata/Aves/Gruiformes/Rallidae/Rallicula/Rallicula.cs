using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Rallicula;

/// <summary>
/// Abstract class for Rallicula (genus).
/// NCBI TaxId: 2861756
/// </summary>
public abstract class Rallicula : Rallidae, IRallicula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rallicula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2861756;

    /// <inheritdoc />
    public virtual string GenusName => "Rallicula";

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
