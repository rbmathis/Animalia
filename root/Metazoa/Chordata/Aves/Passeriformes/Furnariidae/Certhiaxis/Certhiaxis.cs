using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Certhiaxis;

/// <summary>
/// Abstract class for Certhiaxis (genus).
/// NCBI TaxId: 329500
/// </summary>
public abstract class Certhiaxis : Furnariidae, ICerthiaxis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Certhiaxis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329500;

    /// <inheritdoc />
    public virtual string GenusName => "Certhiaxis";

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
