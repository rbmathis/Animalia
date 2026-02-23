using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cisticolidae.Rhopophilus;

/// <summary>
/// Abstract class for Rhopophilus (genus).
/// NCBI TaxId: 330744
/// </summary>
public abstract class Rhopophilus : Cisticolidae, IRhopophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhopophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 330744;

    /// <inheritdoc />
    public virtual string GenusName => "Rhopophilus";

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
