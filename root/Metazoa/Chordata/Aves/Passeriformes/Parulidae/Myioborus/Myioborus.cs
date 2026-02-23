using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Myioborus;

/// <summary>
/// Abstract class for Myioborus (genus).
/// NCBI TaxId: 182937
/// </summary>
public abstract class Myioborus : Parulidae, IMyioborus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myioborus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182937;

    /// <inheritdoc />
    public virtual string GenusName => "Myioborus";

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
