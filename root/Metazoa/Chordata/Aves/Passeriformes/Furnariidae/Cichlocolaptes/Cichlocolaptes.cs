using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Cichlocolaptes;

/// <summary>
/// Abstract class for Cichlocolaptes (genus).
/// NCBI TaxId: 1094393
/// </summary>
public abstract class Cichlocolaptes : Furnariidae, ICichlocolaptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cichlocolaptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1094393;

    /// <inheritdoc />
    public virtual string GenusName => "Cichlocolaptes";

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
