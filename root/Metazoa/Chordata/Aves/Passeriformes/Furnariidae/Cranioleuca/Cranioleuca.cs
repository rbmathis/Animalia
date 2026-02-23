using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Cranioleuca;

/// <summary>
/// Abstract class for Cranioleuca (genus).
/// NCBI TaxId: 85406
/// </summary>
public abstract class Cranioleuca : Furnariidae, ICranioleuca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cranioleuca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 85406;

    /// <inheritdoc />
    public virtual string GenusName => "Cranioleuca";

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
