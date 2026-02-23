using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Limnothlypis;

/// <summary>
/// Abstract class for Limnothlypis (genus).
/// NCBI TaxId: 103047
/// </summary>
public abstract class Limnothlypis : Parulidae, ILimnothlypis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limnothlypis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103047;

    /// <inheritdoc />
    public virtual string GenusName => "Limnothlypis";

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
