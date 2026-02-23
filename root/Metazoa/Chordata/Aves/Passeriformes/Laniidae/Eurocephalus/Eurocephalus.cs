using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Laniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Laniidae.Eurocephalus;

/// <summary>
/// Abstract class for Eurocephalus (genus).
/// NCBI TaxId: 187430
/// </summary>
public abstract class Eurocephalus : Laniidae, IEurocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eurocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187430;

    /// <inheritdoc />
    public virtual string GenusName => "Eurocephalus";

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
