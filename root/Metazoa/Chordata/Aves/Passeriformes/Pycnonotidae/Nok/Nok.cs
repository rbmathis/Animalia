using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Nok;

/// <summary>
/// Abstract class for Nok (genus).
/// NCBI TaxId: 3150825
/// </summary>
public abstract class Nok : Pycnonotidae, INok
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nok";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150825;

    /// <inheritdoc />
    public virtual string GenusName => "Nok";

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
