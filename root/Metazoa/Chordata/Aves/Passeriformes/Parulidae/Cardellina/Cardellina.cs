using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Cardellina;

/// <summary>
/// Abstract class for Cardellina (genus).
/// NCBI TaxId: 182911
/// </summary>
public abstract class Cardellina : Parulidae, ICardellina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cardellina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182911;

    /// <inheritdoc />
    public virtual string GenusName => "Cardellina";

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
