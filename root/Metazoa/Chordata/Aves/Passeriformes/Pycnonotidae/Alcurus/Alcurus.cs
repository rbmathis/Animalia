using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Alcurus;

/// <summary>
/// Abstract class for Alcurus (genus).
/// NCBI TaxId: 3150823
/// </summary>
public abstract class Alcurus : Pycnonotidae, IAlcurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alcurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150823;

    /// <inheritdoc />
    public virtual string GenusName => "Alcurus";

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
