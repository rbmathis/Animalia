using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Campethera;

/// <summary>
/// Abstract class for Campethera (genus).
/// NCBI TaxId: 265617
/// </summary>
public abstract class Campethera : Picidae, ICampethera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Campethera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 265617;

    /// <inheritdoc />
    public virtual string GenusName => "Campethera";

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
