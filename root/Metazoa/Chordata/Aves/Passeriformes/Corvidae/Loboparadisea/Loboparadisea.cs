using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Loboparadisea;

/// <summary>
/// Abstract class for Loboparadisea (genus).
/// NCBI TaxId: 108827
/// </summary>
public abstract class Loboparadisea : Corvidae, ILoboparadisea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Loboparadisea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108827;

    /// <inheritdoc />
    public virtual string GenusName => "Loboparadisea";

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
