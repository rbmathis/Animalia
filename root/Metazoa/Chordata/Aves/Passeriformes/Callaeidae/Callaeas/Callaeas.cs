using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Callaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Callaeidae.Callaeas;

/// <summary>
/// Abstract class for Callaeas (genus).
/// NCBI TaxId: 192206
/// </summary>
public abstract class Callaeas : Callaeidae, ICallaeas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callaeas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 192206;

    /// <inheritdoc />
    public virtual string GenusName => "Callaeas";

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
