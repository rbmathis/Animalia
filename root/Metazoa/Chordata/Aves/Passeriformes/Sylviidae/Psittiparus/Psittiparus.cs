using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Psittiparus;

/// <summary>
/// Abstract class for Psittiparus (genus).
/// NCBI TaxId: 2485344
/// </summary>
public abstract class Psittiparus : Sylviidae, IPsittiparus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psittiparus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2485344;

    /// <inheritdoc />
    public virtual string GenusName => "Psittiparus";

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
