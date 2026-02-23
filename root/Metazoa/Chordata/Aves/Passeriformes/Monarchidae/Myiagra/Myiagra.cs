using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Monarchidae.Myiagra;

/// <summary>
/// Abstract class for Myiagra (genus).
/// NCBI TaxId: 107223
/// </summary>
public abstract class Myiagra : Monarchidae, IMyiagra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myiagra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107223;

    /// <inheritdoc />
    public virtual string GenusName => "Myiagra";

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
