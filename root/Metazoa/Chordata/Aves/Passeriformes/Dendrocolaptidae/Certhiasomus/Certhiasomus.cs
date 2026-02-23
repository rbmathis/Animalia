using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Certhiasomus;

/// <summary>
/// Abstract class for Certhiasomus (genus).
/// NCBI TaxId: 2821141
/// </summary>
public abstract class Certhiasomus : Dendrocolaptidae, ICerthiasomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Certhiasomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821141;

    /// <inheritdoc />
    public virtual string GenusName => "Certhiasomus";

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
