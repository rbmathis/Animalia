using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Arundinicola;

/// <summary>
/// Abstract class for Arundinicola (genus).
/// NCBI TaxId: 495152
/// </summary>
public abstract class Arundinicola : Tyrannidae, IArundinicola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arundinicola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495152;

    /// <inheritdoc />
    public virtual string GenusName => "Arundinicola";

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
