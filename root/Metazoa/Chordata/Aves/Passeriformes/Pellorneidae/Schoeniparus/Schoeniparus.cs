using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae.Schoeniparus;

/// <summary>
/// Abstract class for Schoeniparus (genus).
/// NCBI TaxId: 2485346
/// </summary>
public abstract class Schoeniparus : Pellorneidae, ISchoeniparus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schoeniparus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2485346;

    /// <inheritdoc />
    public virtual string GenusName => "Schoeniparus";

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
