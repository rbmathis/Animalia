using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pycnonotidae.Acritillas;

/// <summary>
/// Abstract class for Acritillas (genus).
/// NCBI TaxId: 1602265
/// </summary>
public abstract class Acritillas : Pycnonotidae, IAcritillas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acritillas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1602265;

    /// <inheritdoc />
    public virtual string GenusName => "Acritillas";

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
